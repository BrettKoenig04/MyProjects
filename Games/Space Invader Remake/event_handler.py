import pygame
import constants as c

class EventHandler:
    def __init__(self):
        pygame.joystick.init()
        self.num_joysticks = pygame.joystick.get_count()
        self.joystick = None
        if self.num_joysticks:
            self.joystick = pygame.joystick.Joystick(0)
            self.joystick.init()

    def handle_events(self, player):
        for event in pygame.event.get():
            self.check_quit_event_(event)
            self.check_keyboard_event(event, player)
            self.check_joystick_event(event, player)

    @staticmethod
    def check_quit_event_(event):
        if event.type == pygame.QUIT:
                pygame.quit()
                quit()

    def check_keyboard_event(self, event, player):
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_a:
                player.velocity_x = -player.speed
            elif event.key == pygame.K_d:
                player.velocity_x = +player.speed
            if event.key == pygame.K_SPACE:
                player.shoot()
        if event.type == pygame.KEYUP:
            if event.key == pygame.K_a:
                player.velocity_x = 0
            elif event.key == pygame.K_d:
                player.velocity_x = 0

    def check_joystick_event(self, event, player):
        if event.type == pygame.JOYHATMOTION:
            if self.joystick.get_hat(0) == c.xb_dpad_left:
                player.velocity_x = -player.speed
            elif self.joystick.get_hat(0) == c.xb_dpad_right:
                player.velocity_x = player.speed
            if self.joystick.get_hat(0) == c.xb_dpad_stopped:
                player.velocity_x = 0
        if event.type == pygame.JOYBUTTONDOWN:
            if self.joystick.get_button(c.xb_a):
                player.shoot()