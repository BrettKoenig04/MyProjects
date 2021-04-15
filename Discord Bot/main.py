import discord
from discord.ext import commands
import os
import time

intents = discord.Intents.default()  
intents.members = True
client = discord.Client(intents=intents)

@client.event
async def on_ready():
    print('We have logged in as: {0.user}'.format(client))

@client.event
async def on_message(message):
    if message.author == client.user:
        return

    if message.content.startswith('!purge'): #TODO - Setup permissions for certain commands.
        await message.channel.purge()

client.run(os.environ.get('token'))