import requests
import json


#//////////////////////////////////////////////////////////////////////////
#// 1. Send a request to https://www.dnd5eapi.co/api/monsters/bugbear
#// 2. Get the responses and deserialize it into a dictionary
#// 3. Display the monster dictionary
#/////////////////////////////////////////////////////////////////////////
response = requests.get('https://www.dnd5eapi.co/api/monsters/bugbear')
data = json.loads(response.text)

names = ["chimera", "bugbear", "dryad", "gargoyle"]

def print_monster(data):
    print(f" Name:      {data['name']}")
    print(f" Alignment: {data['alignment']}")
    print(f" STR:       {data['strength']}")
    print(f" DEX:       {data['dexterity']}")
    print(f" CON:       {data['constitution']}")
    print(f" INT:       {data['intelligence']}")
    print(f" WIS:       {data['wisdom']}")
    print(f" CHA:       {data['charisma']}")
    # print each action's name separated by comma
    print(f" Actions:   {', '.join([action['name'] for action in data['actions']])}")
    print()

for name in names:
    response = requests.get(f'https://www.dnd5eapi.co/api/monsters/{name}')
    data = json.loads(response.text)
    print_monster(data)