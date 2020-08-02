class Player
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    private Movement _movement = new Movement();
    private Weapon _weapone = new Weapon();
}

class Movement
{
    public float DirectionX { get; private set; }
    public float DirectionY { get; private set; }
    public float Speed { get; private set; }

    public Movement()
    {

    }

    public void Move()
    {
        //Do move
    }
}

class Weapon
{
    public float WeaponCooldown { get; private set; }
    public int WeaponDamage { get; private set; }

    public Weapon()
    {

    }

    public void Attack()
    {
        //attack
    }

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }
}