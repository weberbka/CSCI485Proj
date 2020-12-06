using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData {
	public struct Weapon
	{
		public string name;
		public int typeDice;
		public int numDice;
	}
	public struct Enemy
	{
		public string name;
		public int typeDice;
		public int numDice;
	}
	public struct Loot
	{
		public string name;
		public float food;
		public float weapons;
		public float medicine;
		public float wood;
		public float iron;
	}
	
	public static Loot wheelOfLoot(string name){
		if(name == "Zombie"){
			float yourRoll = Random.Range(1.00f, 100.00f);
			if(yourRoll > 99) new Loot{name = "Dark amulet", weapons = 0.5f};
			if(yourRoll > 70) new Loot{name = "Dead rabbit", food = 1f};
			return new Loot{name = "Zombie guts"};
		}
		return new Loot{name = "Nothing"};
	}
	
	public static bool killSignal = false;
	
	//public static Weapon weapon = new Weapon{name = "Fists", typeDice = 6, numDice = 1};
	public static Weapon weapon = new Weapon{name = "Hammer of Dev", typeDice = 20, numDice = 5};
	public static Enemy currentBattle = new Enemy{name = "Zombie", typeDice = 6, numDice = 1};
	public static Stack<Loot> Inventory = new Stack<Loot>();
}
