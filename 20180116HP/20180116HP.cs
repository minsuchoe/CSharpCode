using System;

class LivingEntity {
  public float health = 100;
  
  public virtual void TakeDamage(float damage) {    //virtual
    health -= damage;
    Console.WriteLine("HP : " + health);
  }
}

class Enemy : LivingEntity {
  public override void TakeDamage (float damage) {    //override
    if (damage >= health) {
      Console.WriteLine("Add user's XP point");
      Console.WriteLine("Death effect");
      health = 0;
    } else
    base.TakeDamage(damage);      //base. (= parent class's result value call)
  }
}

class Player : LivingEntity {
  public override void TakeDamage (float damage) {    //override
    if (damage >= health) {
      Console.WriteLine("Revive");
      health = 100;
    } else
    base.TakeDamage(damage);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Enemy anEnemy = new Enemy();
    Player aPlayer = new Player();
    
    anEnemy.TakeDamage(10);
    Console.WriteLine(anEnemy.health == 90);
    aPlayer.TakeDamage(100);
    Console.WriteLine(aPlayer.health == 100);
    
    LivingEntity[] le = new LivingEntity[2];      // 8bytes([0], [1]) Array
    le[0] = new Enemy();
    le[1] = new Player();
    
    foreach (LivingEntity anEntity in le) {
      anEntity.TakeDamage(20);
    }
    Console.WriteLine(le[0].health == 80);
    Console.WriteLine(le[1].health == 80);
    
    le[0].TakeDamage(100);
  }
}