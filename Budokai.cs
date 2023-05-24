using System;

class Budokai
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What do you want to call your Charmander?");
        String answername = Console.ReadLine();
      
        Pokemon charmander = new Pokemon(answername, "Fire", 100);

        Console.WriteLine(charmander.getName());
        Console.WriteLine(charmander.getType());
        Console.WriteLine(charmander.getHP());
        Console.WriteLine("===============");
        String answer1 = "Y";
      while (answer1 == "Y"){
        Console.WriteLine("Use Growl? [Y/N]");
          answer1 = Console.ReadLine();
            if (answer1 == "Y"){
              for (int i = 0; i < 10; i++){
                Console.WriteLine(charmander.Growl());
                }
            }
        else{
          Console.WriteLine("Fight's Over!");
        }
      }
    }
}

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
