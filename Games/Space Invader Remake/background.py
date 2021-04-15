import pygame
import random
import constants as c
from star import Star
from planet import Planet

class Background(pygame.sprite.Sprite):
    def __init__(self):
        super(Background, self).__init__()
        self.image = pygame.Surface(c.display_size)
        self.color = (0, 0, 10)
        self.image.fill(self.color)
        self.rect = self.image.get_rect()
        self.stars = pygame.sprite.Group()
        self.planets = pygame.sprite.Group()
        self.star_timer = random.randrange(1, 10)
        self.planet_timer = random.randrange(60, 120)
        self.max_planets = 3
        self.current_num_planets = 0

    def update(self):
        self.planets.update()
        for planet in self.planets:
            if planet.rect.y > c.display_height:
                self.planets.remove(planet)
                self.current_num_planets -= 1
        if self.planet_timer <= 0:
            if self.current_num_planets >= self.max_planets:
                pass
            else:
                new_planet = Planet()
                self.planets.add(new_planet)
                self.current_num_planets += 1
                self.planet_timer = random.randrange(60,120)
        
        self.stars.update()
        for star in self.stars:
            if star.rect.y >= c.display_height:
                self.stars.remove(star)
        if self.star_timer == 0:
            new_star = Star()
            self.stars.add(new_star)
            self.star_timer = random.randrange(1, 10)
        self.image.fill(self.color)
        self.planets.draw(self.image)
        self.stars.draw(self.image)
        self.planet_timer -= 1
        self.star_timer -= 1