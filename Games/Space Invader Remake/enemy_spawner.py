import pygame
import random
import constants as c
from enemy import Enemy
from enemy_2 import Enemy2

class EnemySpawner:
    def __init__(self):
        self.enemy_group = pygame.sprite.Group()
        self.spawn_timer = random.randrange(30, 120)
        self.max_enemies = 3
        self.enemies = pygame.sprite.Group()

    def update(self):
        self.enemy_group.update()
        for enemy in self.enemy_group:
            if enemy.rect.y >= c.display_height:
                self.enemy_group.remove(enemy)
        if self.spawn_timer == 0:
            self.spawn_enemy()
            self.spawn_timer = random.randrange(30, 120)
        else:
            self.spawn_timer -= 1

    def spawn_enemy(self):
        random_number = random.randrange(0, 100)
        if random_number <=75:
            new_enemy = Enemy()
            self.enemy_group.add(new_enemy)
        elif random_number >= 76:
            if not len(self.enemies) >= self.max_enemies:
                new_enemy = Enemy2()
                self.enemies.add(new_enemy)
                self.enemy_group.add(new_enemy)