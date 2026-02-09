using System.Runtime.InteropServices;

namespace Projekt_fakt; 


public class Charakter(string name, int maxHP, int HP, int maxMN, int MN, int MelleeDmG, int[] AbilityDmG)
{
    
    private string Name = name;
    private int MaxHP = maxHP;
    private int MaxMN = maxMN;
    private int hP = HP;
    private int mN = MN;
    private int melleeDmG = MelleeDmG;
    private int[] abilityDmG = new int[AbilityDmG.Length];
    
}



public class Enemy(string ename, int emaxHP, int eHP, int emaxMN, int eMN, int eMelleeDmG, int[] eAbilityDmG)
{

    private string Name = ename;
    private int MaxHP = emaxHP;
    private int MaxMN = emaxMN;
    private int hP = eHP;
    private int mN = eMN;
    private int melleeDmG = eMelleeDmG;
    private int[] abilityDmG = new int[eAbilityDmG.Length];
    
}



class gamestate 
{

    
    
    
}