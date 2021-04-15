import pygame
import random
import constants as c

class Planet(pygame.sprite.Sprite):
    def __init__(self):
        super(Planet, self).__init__()
        self.planet_01 = pygame.image.load('images\planet_01.png').convert_alpha()
        self.planet_02 = pygame.image.load('images\planet_02.png').convert_alpha()
        self.planet_03 = pygame.image.load('images\planet_03.png').convert_alpha()
        self.planet_04 = pygame.image.load('images\planet_04.png').convert_alpha()
        self.planet_05 = pygame.image.load('images\planet_05.png').convert_alpha()
        self.img_planets = [self.planet_01,
                            self.planet_02,
                            self.planet_03,
                            self.planet_04,
                            self.planet_05]

        self.num_planets = len(self.img_planets)
        self.img_index = random.randrange(0, self.num_planets - 1)
        self.image = self.img_planets[self.img_index]
        self.scale_value = random.uniform(0.25, 1.0)
        self.image = pygame.transform.scale(self.image, (int(self.image.get_width() * self.scale_value),
                                                         int(self.image.get_height() * self.scale_value)))
        self.rect = self.image.get_rect()
        self.rect.x = random.randrange(0, c.display_width - self.rect.width)
        self.rect.y = 0 - self.rect.height
        self.position_x = random.randrange(0, c.display_width - self.rect.width)
        self.position_y = 0 - self.rect.height
        self.velocity_x = 0.0
        self.velocity_y = random.uniform(0.1, 1.5)

    def update(self):
        self.position_x += self.velocity_x
        self.position_y += self.velocity_y
        self.rect.x = int(self.position_x)
        self.rect.y = int(self.position_y)