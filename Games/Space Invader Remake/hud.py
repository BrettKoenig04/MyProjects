import pygame
import constants as c
from health_bar import HealthBar
from heart_icon import HeartIcon
from score import Score
from lives import Lives

class HUD(pygame.sprite.Sprite):
    def __init__(self, hp, num_lives):
        super(HUD, self).__init__()
        self.image = pygame.image.load('images\hud_bar.png').convert_alpha()
        self.rect = self.image.get_rect()
        self.rect.y = c.display_height - self.rect.height
        self.velocity_x = 0
        self.velocity_y = 0
        self.health_bar = HealthBar(hp)
        self.health_bar.rect.x = 10
        self.health_bar.rect.y = c.display_height - self.health_bar.rect.height - 8
        self.health_bar_group = pygame.sprite.Group()
        self.health_bar_group.add(self.health_bar)
        self.score = Score()
        self.score_group = pygame.sprite.Group()
        self.score_group.add(self.score)
        self.heart_icon = HeartIcon(hp)
        self.lives = Lives(num_lives)
        self.lives.rect.x = 222
        self.lives.rect.y = c.display_height - 38
        self.icons_group = pygame.sprite.Group()
        self.icons_group.add(self.heart_icon)
        self.icons_group.add(self.lives)

    def update(self):
        self.health_bar_group.update()
        self.icons_group.update()
        self.score_group.update()
        self.rect.x += self.velocity_x
        self.rect.y += self.velocity_y