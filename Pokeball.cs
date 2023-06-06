class Pokeball{
    public Pokemon pokemon;
    public Pokeball(Pokemon pokemon){
        this.pokemon = pokemon;
    }
    public Pokemon getPokemon()
    {
        return pokemon;
    }

    public void setPokemon(Pokemon pokemon){
        this.pokemon = pokemon;
    }
}