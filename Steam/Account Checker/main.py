from selenium import webdriver
from time import sleep
from selenium.common.exceptions import NoSuchElementException

accountDict = {}

# Opens file and grabs each user and password combination
with open('filename.txt') as f:
    lines = [line.rstrip() for line in f]
    accountDict = dict(s.split(':') for s in lines)

username = ''
password = ''

setprofile = '//*[@id="btn"]/a/span'
bannedaccount = 'profile_ban'

driver = webdriver.Chrome()

# Loop through each account and checks account status
for (key, value) in accountDict.items():
    username = key
    password = value

    driver.get('https://steamcommunity.com/login/')
    driver.find_element_by_xpath('//*[@id="steamAccountName"]').send_keys(username)
    driver.find_element_by_xpath('//*[@id="steamPassword"]').send_keys(password)
    driver.find_element_by_xpath('//*[@id="SteamLogin"]').click()
    sleep(4)

    try:
        driver.find_element_by_xpath('/html/body/div[3]/div[3]/div/div/div/form/div[1]')
        print('Steam Guard Enabled (last known status ↓)')
    except NoSuchElementException:
        driver.get('https://steamcommunity.com/login/')
        pass       

    try:
        driver.find_element_by_class_name(bannedaccount)
        print('Banned: ', username, password)
    except NoSuchElementException:
        pass

    try:
        driver.find_element_by_class_name(bannedaccount)
    except NoSuchElementException:
        print('Unbanned: ', username, password)
        pass

    try:
        driver.find_element_by_xpath('//*[@id="account_pulldown"]')
        driver.find_element_by_xpath('//*[@id="account_pulldown"]').click()
        driver.find_element_by_xpath('//*[@id="account_dropdown"]/div/a[3]').click()
    except NoSuchElementException:
        pass