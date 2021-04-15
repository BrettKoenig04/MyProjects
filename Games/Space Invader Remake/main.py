import pygame
from ship import Ship
import constants as c
from background import Background
from enemy_spawner import EnemySpawner
from particle_spawner import ParticleSpawner
from event_handler import EventHandler

# Audio settings
pygame.mixer.pre_init(44100, -16, 2, 512)
pygame.init()
pygame.mixer.init()
pygame.font.init

# Display setup
display = pygame.display.set_mode(c.display_size)
pygame.display.set_caption('Space Invader Remake - v1.0')
fps = 60
clock = pygame.time.Clock()
remove_ship_per_frame = (0, 0, 0)

# Objects setup
event_handler = EventHandler()
background = Background()
background_group = pygame.sprite.Group()
background_group.add(background)
player = Ship()
sprite_group = pygame.sprite.Group()
sprite_group.add(player)
enemy_spawner = EnemySpawner()
particle_spawner = ParticleSpawner()

# Background music
pygame.mixer.music.load('sounds\sound_bg_music.ogg')
pygame.mixer.music.set_volume(.5)
pygame.mixer.music.play(-1)

running = True

while running:
    # Tick Clock
    clock.tick(fps)
    
    # Handle Events
    event_handler.handle_events(player)

    # Update all objects
    background_group.update()
    sprite_group.update()
    enemy_spawner.update()
    particle_spawner.update()

    # Check collision
    collided = pygame.sprite.groupcollide(player.bullets, enemy_spawner.enemy_group, True, False)
    for bullet, enemy in collided.items():
        enemy[0].get_hit()
        player.hud.score.update_score(enemy[0].score_value)
        if not enemy[0].is_invincible:
            particle_spawner.spawn_particles((bullet.rect.x, bullet.rect.y))
    collided = pygame.sprite.groupcollide(sprite_group, enemy_spawner.enemy_group, False, False)
    for player, enemy in collided.items():
        if not enemy[0].is_invincible and not player.is_invincible:
            player.get_hit()
            enemy[0].hp = 0
            enemy[0].get_hit()
    for enemy in enemy_spawner.enemy_group:
        collided = pygame.sprite.groupcollide(sprite_group, enemy.bullets, False, True)
        for player, bullet in collided.items():
            if not player.is_invincible:
                player.get_hit()

    # Render to display
    display.fill(remove_ship_per_frame)
    background_group.draw(display)
    sprite_group.draw(display)
    player.bullets.draw(display)
    enemy_spawner.enemy_group.draw(display)

    for enemy in enemy_spawner.enemy_group:
        enemy.bullets.draw(display)

    particle_spawner.particle_group.draw(display)
    player.hud_group.draw(display)
    player.hud.health_bar_group.draw(display)
    player.hud.icons_group.draw(display)
    player.hud.score_group.draw(display)
    pygame.display.update()