import pygame
import random
import constants as c
from bullet import Bullet
import enemy_spawner

class Enemy2(pygame.sprite.Sprite):
    def __init__(self):
        super(Enemy2, self).__init__()
        self.img_explosion_01 = pygame.image.load('images\explosion_01.png').convert_alpha()
        self.img_explosion_02 = pygame.image.load('images\explosion_02.png').convert_alpha()
        self.img_explosion_03 = pygame.image.load('images\explosion_03.png').convert_alpha()
        self.img_explosion_04 = pygame.image.load('images\explosion_04.png').convert_alpha()
        self.img_explosion_05 = pygame.image.load('images\explosion_05.png').convert_alpha()
        
        self.anim_explosion = [self.img_explosion_01,
                               self.img_explosion_02,
                               self.img_explosion_03,
                               self.img_explosion_04,
                               self.img_explosion_05]

        self.anim_index = 0
        self.frame_length_max = 8
        self.frame_length = self.frame_length_max
        self.image = pygame.image.load('images\enemy2.png').convert_alpha()
        self.image = pygame.transform.scale(self.image, (int(self.image.get_width() / 9), int(self.image.get_height() / 9)))
        self.is_destroyed = False
        self.is_invincible = False

        self.rect = self.image.get_rect()
        self.rect.x = random.randrange(0, c.display_width - self.rect.width)
        self.rect.y = -self.rect.height
        self.snd_hit = pygame.mixer.Sound('sounds\sound_bullet_hit.ogg')
        self.hp = 3
        self.bullets = pygame.sprite.Group()
        self.bullet_timer_max = 60
        self.bullet_timer = self.bullet_timer_max
        self.states = {'fly_down': 'fly_down',
                       'attack': 'attack'}
        self.state = self.states['fly_down']
        self.init_state = True
        self.score_value = 5
        self.velocity_x = 0
        self.velocity_y = random.randrange(3, 4)

    def update(self):
        self.bullets.update()
        if self.state == 'fly_down':
            self.state_fly_down()
        elif self.state == 'attack':
            self.state_attack()
        self.rect.x += self.velocity_x
        self.rect.y += self.velocity_y

        if self.is_destroyed:
            max_index = len(self.anim_explosion) - 1
            if self.frame_length == 0:
                self.anim_index += 1
                if self.anim_index > max_index:
                    self.kill()
                    enemy_spawner.EnemySpawner().enemies.remove([1])
                else:
                    self.image = self.anim_explosion[self.anim_index]
                    self.frame_length = self.frame_length_max
            else:
                self.frame_length -= 1

    def state_fly_down(self):
        if self.init_state:
            self.init_state = False
        if self.rect.y >= 200:
            self.state = self.states['attack']
            self.init_state = True

    def state_attack(self):
        if self.init_state:
            self.velocity_y = 0
            while self.velocity_x == 0:
                self.velocity_x = random.randrange(-4, 4)
            self.init_state = False
        if self.bullet_timer == 0:
            self.shoot()
            self.bullet_timer = self.bullet_timer_max
        else:
            self.bullet_timer -= 1
        if self.rect.x <= 0:
            self.velocity_x *= -1
        elif self.rect.x + self.rect.width >= c.display_width:
            self.velocity_x *= -1

    def shoot(self):
        new_bullet = Bullet()
        new_bullet.velocity_y = 4
        new_bullet.rect.x = self.rect.x + (self.rect.width // 2)
        new_bullet.rect.y = self.rect.y + self.rect.height
        self.bullets.add(new_bullet)

    def get_hit(self):
        if not self.is_invincible:
            self.snd_hit.play()
            self.hp -=1

            if self.hp <= 0:
                self.is_invincible = True
                self.is_destroyed = True
                self.velocity_x = 0
                self.velocity_y = 0
                self.rect.x = self.rect.x - 30
                self.rect.y = self.rect.y - 44
                self.image = self.anim_explosion[self.anim_index]
        else:
            pass