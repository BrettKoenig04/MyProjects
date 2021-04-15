import pygame
import constants as c
from bullet import Bullet
from hud import HUD

class Ship(pygame.sprite.Sprite):
    def __init__(self):
        super(Ship, self).__init__()

        # Store image and give properties for position and speed
        self.image = pygame.image.load('images\ship.png').convert_alpha()
        self.image = pygame.transform.scale(self.image, (int(self.image.get_width() / 9), int(self.image.get_height() / 9)))
        self.rect = self.image.get_rect()
        self.rect.x = c.display_width // 2
        self.rect.y = c.display_height - self.rect.height * 2
        self.bullets = pygame.sprite.Group()
        self.snd_shoot = pygame.mixer.Sound('sounds\sound_bullet_shot.ogg')
        self.max_hp = 3
        self.lives = 3
        self.hp = self.max_hp
        self.snd_hit = pygame.mixer.Sound('sounds\sound_bullet_hit.ogg')
        self.hud = HUD(self.hp, self.lives)
        self.hud_group = pygame.sprite.Group()
        self.hud_group.add(self.hud)
        self.is_invincible = False
        self.max_invincible_timer = 60
        self.invincible_timer = 0
        self.invincible_timer = self.max_invincible_timer
        self.velocity_x = 0
        self.velocity_y = 0
        self.speed = 5

    def update(self):
        self.bullets.update()
        self.hud_group.update()
        for bullet in self.bullets:
            if bullet.rect.y <= 0:
                self.bullets.remove(bullet)

        self.rect.x += self.velocity_x
        if self.rect.x <= 0:
            self.rect.x = 0
        elif self.rect.x >= c.display_width - self.rect.width:
            self.rect.x = c.display_width - self.rect.width   
        self.rect.y += self.velocity_y

        # Check for invincibility
        if self.invincible_timer > 0:
            self.invincible_timer -= 1
        else:
            self.is_invincible = False

    def shoot(self):
        self.snd_shoot.play()
        new_bullet = Bullet()
        new_bullet.rect.x = self.rect.x + (self.rect.width // 2) - 1
        new_bullet.rect.y = self.rect.y
        self.bullets.add(new_bullet)

    def get_hit(self):
        self.hp -= 1
        self.snd_hit.play()
        self.hud.health_bar.decrease_hp_value()
        if self.hp <= 0:
            self.hp = 0
            self.death()

    def death(self):
        self.lives -= 1
        if self.lives <= 0:
            self.lives = 0
        self.hp = self.max_hp
        self.hud.health_bar.reset_health_to_max()
        self.hud.lives.decrement_life()
        self.rect.x = c.display_width // 2
        self.is_invincible = True
        self.invincible_timer = self.max_invincible_timer