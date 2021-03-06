﻿using System.Collections;
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
		public string type;
		public float worth;
	}
	
	public static Loot wheelOfLoot(string name){
		if(name == "Zombie"){
			float yourRoll = Random.Range(1.00f, 100.99f);
			if(yourRoll > 95) return new Loot{name = "Magic amulet", type = "weapons", worth = 0.5f};
			if(yourRoll > 75) return new Loot{name = "3 bullets", type = "weapons", worth = 0.05f};
			if(yourRoll > 60) return new Loot{name = "Rabbit meat", type = "food", worth = 0.2f};
			if(yourRoll > 40) return new Loot{name = "Twinkie", type = "food", worth = 0.1f};
			return new Loot{name = "Zombie guts", type = "worthless", worth = 0f};
		}
		if(name == "Radioactive Rabbit"){
			float yourRoll = Random.Range(1.00f, 100.99f);
			if(yourRoll > 90) return new Loot{name = "Lucky Rabbit Foot", type = "weapons", worth = 0.2f};
			if(yourRoll > 70) return new Loot{name = "Small bones", type = "weapons", worth = 0.05f};
			if(yourRoll > 55) return new Loot{name = "Rabbit meat", type = "food", worth = 0.3f};
			return new Loot{name = "Irradiated meat", type = "worthless", worth = 0f};
		}
		if(name == "Feral Dog"){
			float yourRoll = Random.Range(1.00f, 100.99f);
			if(yourRoll > 85) return new Loot{name = "Dog Meat", type = "food", worth = 0.5f};
			if(yourRoll > 60) return new Loot{name = "Bones", type = "weapons", worth = 0.1f};
			return new Loot{name = "Irradiated meat", type = "worthless", worth = 0f};
		}
		return new Loot{type = "nothing"};
	}
	
	public static void consumeLoot(Loot loot){
		if(loot.type == "food") food += loot.worth;
		if(loot.type == "weapons") weapons += loot.worth;
		if(loot.type == "medicine") medicine += loot.worth;
		if(loot.type == "wood") wood += loot.worth;
		if(loot.type == "iron") iron += loot.worth;
	}
	
	public static bool killSignal = false;
	public static bool killNullify = false;
	
	public static Weapon weapon = new Weapon{name = "Fists", typeDice = 4, numDice = 1};
	public static Weapon lastWeapon = new Weapon{name = "Fists", typeDice = 4, numDice = 1};
	//public static Weapon weapon = new Weapon{name = "Hammer of Dev", typeDice = 20, numDice = 5};
	public static Enemy currentBattle = new Enemy{name = "Zombie", typeDice = 6, numDice = 1};
	public static Vector2 playerPosition = new Vector2(1, 1);
	public static bool useUnityPosition = true;
	
	public static float food = 2;
	public static float weapons = 3;
	public static float medicine = 1;
	public static float wood = 3;
	public static float iron = 0;
}
