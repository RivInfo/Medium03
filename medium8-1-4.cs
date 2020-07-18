class Player
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    private Movement _movement = new Movement();
    private Weapone _weapone = new Weapone();
}

class Movement
{
    public float MovementDirectionX { get; private set; }
    public float MovementDirectionY { get; private set; }
    public float MovementSpeed { get; private set; }

    public Movement()
    {

    }

    public void Move()
    {
        //Do move
    }
}

class Weapone
{
    public float WeaponCooldown { get; private set; }
    public int WeaponDamage { get; private set; }

    public Weapone()
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