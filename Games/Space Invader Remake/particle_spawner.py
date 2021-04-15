import pygame
import random
from particle import Particle

class ParticleSpawner:
    def __init__(self):
        self.particle_group = pygame.sprite.Group()

    def update(self):
        self.particle_group.update()

    def spawn_particles(self, position):
        particle_range = random.randrange(3, 30)
        for num in range(particle_range):
            new_particle = Particle()
            new_particle.rect.x = position[0]
            new_particle.rect.y = position[1]
            self.particle_group.add(new_particle)