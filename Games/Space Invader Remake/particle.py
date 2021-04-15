import pygame
import random
import constants as c

class Particle(pygame.sprite.Sprite):
    def __init__(self):
        super(Particle, self).__init__()
        self.width = random.randrange(1,6)
        self.height = self.width
        self.size = (self.width, self.height)
        self.image = pygame.Surface(self.size)
        self.color = (random.randrange(0, 255), random.randrange(0, 255), random.randrange(0, 255))
        self.image.fill(self.color)
        self.rect = self.image.get_rect()
        self.remove_particle_timer = 60
        self.velocity_x = random.randrange(-16, 16)
        self.velocity_y = random.randrange(-16, 16)

    def update(self):
        self.rect.x += self.velocity_x
        self.rect.y += self.velocity_y
        
        if self.remove_particle_timer == 0:
            self.kill()
        else: self.remove_particle_timer -= 1