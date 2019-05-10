class Pokemon(object):
    def __init__(self, name, type, effectiveAgainst):
        self.name = name
        self.type = type
        self.effectiveAgainst = effectiveAgainst

    def isEffectiveAgainst(self, anotherPokemon):
        return self.effectiveAgainst == anotherPokemon.type


def initializePokemons():
    pokemon = []

    pokemon.append(Pokemon("Balbasaur", "leaf", "water"))
    pokemon.append(Pokemon("Pikatchu", "electric", "water"))
    pokemon.append(Pokemon("Charizard", "fire", "leaf"))
    pokemon.append(Pokemon("Balbasaur", "water", "fire"))
    pokemon.append(Pokemon("Kingler", "water", "fire"))

    return pokemon


def choosePokemon(pokemons: list, wild: Pokemon):

    results=[]
    wild_type=wild.type
    for pok in pokemons:
        if(pok.effectiveAgainst==wild.type):
            results.append(pok.name)
    return results

pokemon = initializePokemons()


# Every pokemon has a name and a type.
# Certain types are effective against others, e.g. water is effective against fire.

# Ash has a few pokemon.
# A wild pokemon appeared!

wildPokemon = Pokemon("Oddish", "leaf", "water")

# Which pokemon should Ash use?

print("I choose you, ",choosePokemon(pokemon,wildPokemon));
