#bullet.py
import pygame
import constants as c

class Bullet(pygame.sprite.Sprite):
    def __init__(self):
        super(Bullet, self).__init__()
        self.width = 3
        self.height = 10
        self.size = (self.width, self.height)
        self.image = pygame.Surface(self.size)
        self.color = (255, 255, 255)
        self.image.fill(self.color)
        self.rect = self.image.get_rect()
        self.velocity_x = 0
        self.velocity_y = -8

    def update(self):
        self.rect.x += self.velocity_x
        self.rect.y += self.velocity_y