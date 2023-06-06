class Pokemon
{
    public String name;
    public String type;
    public int hp;

   
  
   public Pokemon(String askName, String askType, int askHP){
     name = askName;
     type = askType;
     hp = askHP;
   }

    public String getName()
    {
        return name;
    }

    public String getType()
    {
        return type;
    }

    public int getHP()
    {
        return hp;
    }


    public void setName(String name)
    {
        this.name = name;
    }

    public void setType(String type)
    {
        this.type = type;
    }

    public void setHP(int hp)
    {
        this.hp = hp;
    }

    public string Growl(){
      return name;
    } 
}
