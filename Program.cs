using System;

namespace DNDEnemyGenerator
{
	class MainClass
	{
		
		
		
	}
	
	class RandomEnemyCreator 
	{
	
	
		static void Main(string[] args)
		{
			
		/* MAKE SURE TO RE-ENABLE THIS!
			Enemy.Type = enemyType();
			Enemy.Strength = strength();
			Enemy.Dexterity = dexterity();
			Enemy.Constitution = constitution();
			Enemy.Intelligence = intelligence();
			Enemy.Wisdom = wisdom();
			Enemy.Charisma = charisma();*/

			// The below code is to test the randomness of the class creator. 
			/*
						int arCount = 0;
						int fiCount = 0;
						int roCount = 0;
						for (int i = 100000; i >= 0; i--)
						{
							Enemy.Type = enemyType();
							//Console.WriteLine(Enemy.Type);
							if (Enemy.Type == "Archer")
							{
								arCount++;
							}
							else if (Enemy.Type == "Fighter")
							{
								fiCount++;
							}
							else if (Enemy.Type == "Rogue")
							{
								roCount++;
							}
						} 
			//I developed most of this write method to test randomness...
						Console.WriteLine("Archers: {0} Fighters: {1} Rogues {2}", 
							arCount, 
							fiCount, 
							roCount); */
			//Tests statbuilds	

			int fiCount = 0;
						
			for (int i = 100; i >= 0; i--)
			{
				Enemy.Type = enemyType();
				int [] stats = attributes();
				Enemy.Strength = stats[0];
				Enemy.Dexterity = stats[1];
				Enemy.Constitution = stats[2];
				Enemy.Intelligence = stats[3];
				Enemy.Wisdom = stats[4];
				Enemy.Charisma = stats[5];
				int[] mods = modifiers(stats);
				Enemy.HP = hP(mods[2]);
				Enemy.Armor = armorType();
				Enemy.WeaponLoadout = weaponType();
				
				//Below is counter.
				if (Enemy.Type == "Fighter")
				{
					fiCount++;
				}
				/* The above code utilizes the "stat" array.
				Enemy.Strength = attributes[0];
				Enemy.Dexterity = dexterity();
				Enemy.Constitution = constitution();
				Enemy.Intelligence = intelligence();
				Enemy.Wisdom = wisdom();
				Enemy.Charisma = charisma();*/
				Console.Write("\n---------------\nType: {0} \nHP: {1}\nAC: Armor AC " + 
						"+ Shield (if applicable) + Dexterity Modifier\nArmor: {2}\nGear: {3}",
				 Enemy.Type, Enemy.HP, Enemy.Armor, Enemy.WeaponLoadout); 

				Console.Write("\n-Attributes- \nStrength: {0} \nDexterity: {1}" +
					"\nConstitution: {2}\nIntelligence: {3} \nWisdom: {4} \n" +
					"Charisma: {5}\n\n", Enemy.Strength, Enemy.Dexterity,
					Enemy.Constitution, Enemy.Intelligence, Enemy.Wisdom, Enemy.Charisma);
					
				Console.Write("-Modifiers- \nStrength: {0} \nDexterity: {1}" +
					"\nConstitution: {2}\nIntelligence: {3} \nWisdom: {4} \n" +
					"Charisma: {5} \n---------------", mods[0], mods[1], mods[2], 
					mods[3], mods[4], mods[5]);
			}
			Console.WriteLine("Fighters: " + fiCount);
			Console.ReadLine();

		}

		
		
		public static string enemyType()
		{
			string enType = "";
			int type = roll(1, 100000);
			if (type <= 25000)
			{
				enType = "Archer";
			}
			else if (type >= 25001 & type <= 75000)
			{
				enType = "Fighter";
			}
			else if (type >= 75001)
			{
				enType = "Rogue";
			}
			return enType;
		}
		// organized stats into array.
		public static int[] attributes()
		{
			int[] stats = new int[6];
			stats[0] = strength();
			stats[1] = dexterity();
			stats[2] = constitution();
			stats[3] = intelligence();
			stats[4] = wisdom();
			stats[5] = charisma();
			return stats;
		}
		// the next 6 methods define base stats.
		public static int strength()
		{
			int strengf = 0;
			if (Enemy.Type == "Fighter")
			{
				strengf = roll(10, 14);
			}
			else if (Enemy.Type == "Archer")
			{
				strengf = roll(6, 12);
			}
			else if (Enemy.Type == "Rogue")
			{
				strengf = roll(8, 12);
			}
			
			return strengf;
		}
		
		public static int dexterity()
		{
			int dex = 0;
			if (Enemy.Type == "Fighter")
			{
				dex = roll(6, 12);
			}
			else if (Enemy.Type == "Archer")
			{
				dex = roll(8, 15);
			}
			else if (Enemy.Type == "Rogue")
			{
				dex = roll(8, 15);
			}
			
			return dex;
		}
		
		public static int constitution()
		{
			int con = 0;
			if (Enemy.Type == "Fighter")
			{
				con = roll(10, 15);
			}
			else if (Enemy.Type == "Archer")
			{
				con = roll(6, 10);
			}
			else if (Enemy.Type == "Rogue")
			{
				con = roll(8, 12);
			}
			
			return con;
		}
		
		public static int intelligence()
		{
			int intel = 0;
			if (Enemy.Type == "Fighter")
			{
				intel = roll(8, 12);
			}
			else if (Enemy.Type == "Archer")
			{
				intel = roll(8, 12);
			}
			else if (Enemy.Type == "Rogue")
			{
				intel = roll(8, 12);
			}
			
			return intel;
		}
		
		public static int wisdom()
		{
			int wis = 0;
			if (Enemy.Type == "Fighter")
			{
				wis = roll(8, 12);
			}
			else if (Enemy.Type == "Archer")
			{
				wis = roll(8, 12);
			}
			else if (Enemy.Type == "Rogue")
			{
				wis = roll(8, 12);
			}
			
			return wis;
		}
		
		public static int charisma()
		{
			int cha = 0;
			if (Enemy.Type == "Fighter")
			{
				cha = roll(8, 12);
			}
			else if (Enemy.Type == "Archer")
			{
				cha = roll(8, 12);
			}
			else if (Enemy.Type == "Rogue")
			{
				cha = roll(8, 14);
			}
			
			return cha;
		}

		public static int[] modifiers(int[] attributes)
		{
			int[] mods = new int[6];
			mods[0] = attributes[0] / 2 - 5; //Str
			mods[1] = attributes[1] / 2 - 5; //Dex
			mods[2] = attributes[2] / 2 - 5; //Con
			mods[3] = attributes[3] / 2 - 5; //Int
			mods[4] = attributes[4] / 2 - 5; //Wis
			mods[5] = attributes[5] / 2 - 5; //Cha
			return mods;
		}

		public static int hP(int conMod)
		{
			int hp = 0;
			if (Enemy.Type == "Fighter")
			{
				hp = 10 + conMod;
			}
			else if (Enemy.Type == "Archer")
			{
				hp= 8 + conMod;
			}
			else if (Enemy.Type == "Rogue")
			{
				hp = 8 + conMod;
			}
			return hp;
		}

		public static string armorType()
		{
			string aType = "";
			if (Enemy.Type == "Fighter")
				{
					aType = fighterArmor();
				}
				else if (Enemy.Type == "Archer")
				{
					aType = archerArmor();
				}
				else if (Enemy.Type == "Rogue")
				{
					aType = rogueArmor();
				}
			return aType;
		}
		//I need to shorten this method.
		public static string fighterArmor()
		{
			string armor = "";
			int ac = roll(1, 100);

			if (ac <= 60)
			{
				armor = "Chain Shirt \nBase Armor AC = 13";
			}
			else if (ac >= 61)
			{
				armor = "Scale Mail \nBase Armor AC = 14";
			}
			return armor;
		}
		
		public static string archerArmor()
		{	
				string armor = "";
			int ac = roll(1, 100);
			
			if (ac <= 60)
			{
				armor = "Padded \nBase Armor AC = 11";
			}
			else if (ac >=61)
			{
				armor = "Leather \nBase Armor AC = 11";
			}
			return armor;
		}
		
		public static string rogueArmor()
		{
			string armor = "";
			int ac = roll(1, 100);
			
			if (ac <= 60)
			{
				armor = "Padded \nBase Armor AC = 11";
			}
			else if (ac >= 61)
			{
				armor = "Leather \nBase Armor AC = 11";
			}
			return armor;
		}

		public static string weaponType()
		{
			string wType = "";
			if (Enemy.Type == "Fighter")
				{
					wType = fighterWeapon();
				}
				else if (Enemy.Type == "Archer")
				{
					wType = archerWeapon();
				}
				else if (Enemy.Type == "Rogue")
				{
					wType = rogueWeapon();
				}
			return wType;
		}
		
		public static string fighterWeapon()
		{
			string weapon = "";
			int wep = roll(1, 100);

			if (wep <= 47)
			{
				weapon = "Main Weapon: Longsword \nDamage: 1d8 Slashing \nWeapon Properties: Versatile (1d10)\n" +
						"Secondary Weapon: HandAxe \nDamage: 1d6 Slashing \nWeapon Properties: Light, Thrown (Range 20/60)";
			}
			else if (wep >= 48 && wep <= 85)
			{
				weapon = "Main Weapon: Flail \nDamage: 1d8 Bludgeoning \nWeapon Properties: --NONE--\n" +
						"Basic Shield (+2 AC when equipped in offhand)\nSecondary Weapon: Light Hammer (2)\n" +
						"Damage: 1d4 Bludgeoning\n Weapon Properties: Light, Thrown (Range 20/60)";
			}
			else if (wep >= 86)
			{
				weapon = "Main Weapon: Trident\nDamage: 1d6 Piercing\nWeapon Properties: Thrown (Range 20/60)," +
						"Versatile (1d8)\nBasic Shield (+2 AC when equipped in offhand)\nSecondary Weapon: " + 
						"Net (2)\nDamage: --NONE--\nWeapon Properties: Special, Thrown (Range 5/15)";
			}
			
			return weapon;
		}
		
		public static string archerWeapon()
		{	
			string weapon = "";
			int wep = roll(1, 100);
			
			if (wep <= 65)
			{
				weapon = "Main Weapon: Longbow\nDamage: 1d8 Piercing \nWeapon Properties: Ammunition " +
						"(Range 150/600), Heavy, Two-Handed\nSecondary Weapon: Dagger \nDamage: 1d4 " +
						"Piercing \nWeapon Properties: Light, Finesse, Thrown (Range 20/60)";
			}
			else if (wep >=66)
			{
				weapon = "Main Weapon: Heavy Crossbow\nDamage: 1d10 Piercing \nWeapon Properties: Ammunition " +
						"(Range 100/400), Heavy, Two-Handed\nSecondary Weapon: Dagger \nDamage: 1d4 " +
						"Piercing \nWeapon Properties: Light, Finesse, Thrown (Range 20/60)";
			}
			return weapon;
		}
		
		public static string rogueWeapon()
		{
			string weapon = "";
			int wep = roll(1, 100);
			
			if (wep <= 65)
			{
				weapon = "Main Weapon: Shortsword\nDamage: 1d6 Piercing \nWeapon Properties: Finesse, Light" +
						"\nBasic Shield (+2 AC when equipped in offhand)\nSecondary Weapon: Dagger \nDamage: 1d4 " +
						"Piercing \nWeapon Properties: Light, Finesse, Thrown (Range 20/60)";
			}
			else if (wep >= 66)
			{
				weapon = "Main Weapon: Rapier\nDamage: 1d8 Piercing \nWeapon Properties: Finesse\nBasic Shield " +
						"(+2 AC when equipped in offhand)\nSecondary Weapon: Dagger (2) \n\nDamage: 1d4 " +
						"Piercing \nWeapon Properties: Light, Finesse, Thrown (Range 20/60)";
			}
			return weapon;
		}		
		
		
		


		/*public static int roll(int min, int max)
		{

			//Random rnd = new Random();
			int result = rnd.Next(min, max + 1);
			return result;
			
		}*/
			//Below is algorithm I found to make Random more Random.
		private static readonly Random rnd = new Random();
		private static readonly object syncLock = new object();
		public static int roll(int min, int max)
		{
			lock(syncLock)
			{ // synchronize
				return rnd.Next(min, max + 1);
			}
		}

		
		
		
		
		 
	}

	class Enemy
	{
		public static string Type
		{
			get;
			set;
		}
		
		public static string Name
		{
			get;
			set;
		}
		
		public static int HP
		{
			get;
			set;
		}
		
		public static int Attack
		{
			get;
			set;
		}
		
		public static string AttackRange
		{
			get;
			set;
		}
		
		public static string damage
		{
			get;
			set;
		}
		
		public static string Armor
		{
			get;
			set;
		}
		
		public static int AC
		{
			get;
			set;
		}
		
		public static int Initiative
		{
			get;
			set;
		}
		
		public static int Strength
		{
			get;
			set;
		}
		
		public static int Dexterity
		{
			get;
			set;
		}
		
		public static int Constitution
		{
			get;
			set;
		}
		
		public static int Wisdom
		{
			get;
			set;
		}
		
		public static int Intelligence
		{
			get;
			set;
		}
		
		public static int Charisma
		{
			get;
			set;
		}
		public static string WeaponLoadout
		{
			get;
			set;
		}
							
	}

	
}
