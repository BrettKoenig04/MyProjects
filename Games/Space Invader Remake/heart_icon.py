import pygame
import constants as c

class HeartIcon(pygame.sprite.Sprite):
    def __init__(self, hp):
        super(HeartIcon, self).__init__()
        self.image = pygame.image.load('images\heart_icon.png').convert_alpha()
        self.rect = self.image.get_rect()
        self.rect.x = 8
        self.rect.y = c.display_height - self.rect.height - 25