import pygame
import random
import constants as c

class Enemy(pygame.sprite.Sprite):
    def __init__(self):
        super(Enemy, self).__init__()
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
        self.image = pygame.image.load('images\enemy.png').convert_alpha()
        self.image = pygame.transform.scale(self.image, (int(self.image.get_width() / 4), int(self.image.get_height() / 4)))
        self.is_destroyed = False
        self.is_invincible = False

        self.rect = self.image.get_rect()
        self.rect.x = random.randrange(0, c.display_width - self.rect.width)
        self.rect.y = -self.rect.height
        self.snd_hit = pygame.mixer.Sound('sounds\sound_bullet_hit.ogg')
        self.bullets = pygame.sprite.Group()
        self.hp = 3
        self.score_value = 5
        self.velocity_x = 0
        self.velocity_y = random.randrange(3, 5)

    def update(self):
        self.rect.x += self.velocity_x
        self.rect.y += self.velocity_y

        if self.is_destroyed:
            max_index = len(self.anim_explosion) - 1
            if self.frame_length == 0:
                self.anim_index += 1
                if self.anim_index > max_index:
                    self.kill()
                else:
                    self.image = self.anim_explosion[self.anim_index]
                    self.frame_length = self.frame_length_max
            else:
                self.frame_length -= 1

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