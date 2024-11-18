void Main()
{
    
    string msgBoss = "------------------\n" +
        "Ход БОССА\n" +
        "------------------";
    string msgUser = "------------------\n" +
        "Ход пользователя\n" +
        "...................\n" +
        "1 - обычная атака\n" +
        "2 - огненный шар\n" +
        "3 - взрыв\n" +
        "------------------";
    bool flag = true;
    int healthsUser = 100;
    int healthsUserTmp = healthsUser;
    int healthsBoss = 1000;
    int healthsBossTmp = healthsBoss;
    int manaUser = 5;
    int manaUserTmp = manaUser;
    int dmgUser = 10;
    int dmgBoss = 10;
    int cmdUser = 0;
    bool sklFire = false;



    Console.WriteLine("Начинается бой с БОССОМ");

    while (flag)
    {
        if (healthsBossTmp == 0)
        {
            if (healthsUserTmp == 0)
            {
                Console.WriteLine("Бой окончен! НИЧЬЯ!!!");
                flag = false;
            }
            else
            {
                Console.WriteLine("Бой окончен! Победа!!!");
                flag = false;
            }
        }
        else if (healthsUserTmp == 0)
        {
            if (healthsBossTmp == 0)
            {
                Console.WriteLine("Бой окончен! НИЧЬЯ!!!");
                flag = false;
            }
            else
            {
                Console.WriteLine("Бой окончен! Проигрыш!!!");
                flag = false;
            }
        }
        else
        {
            Console.WriteLine(msgUser);
            Console.WriteLine("Маны: " + manaUserTmp);
            cmdUser = Convert.ToUInt16(Console.ReadLine());
            if (cmdUser == 1)
            {
                healthsBossTmp -= dmgUser;
            }
            else if (cmdUser == 2)
            {
                if (manaUserTmp >= 1)
                {
                    healthsBossTmp -= dmgUser * 2;
                    manaUserTmp -= 1;
                    sklFire = true;
                }
                else
                {
                    Console.WriteLine("Промах!");
                }
            }
            else if (cmdUser == 3)
            {
                if (sklFire)
                {
                    if (manaUserTmp >= 2)
                    {
                        healthsBossTmp -= dmgUser * 4;
                        manaUserTmp -= 2;
                        sklFire = false;
                    }
                    else
                    {
                        Console.WriteLine("Промах!");
                    }
                }
                else
                {
                    Console.WriteLine("Промах!");
                }
            }
            else if (cmdUser == 4)
            {
                healthsUserTmp += 50;
                if (healthsUserTmp > healthsUser) { healthsUserTmp = healthsUser;}
                manaUserTmp += 3;
                if (manaUserTmp > manaUser) { manaUserTmp = manaUser;}
            }
            else
            {
                Console.WriteLine("Промах!");
            }
            Console.WriteLine("HP у БОССА осталось: " + healthsBossTmp + "\n\n");
            Console.WriteLine(msgBoss);
            healthsUserTmp -= dmgBoss;
            Console.WriteLine("HP у игрока осталось: " + healthsUserTmp + "\n\n");
        }
    }


}

Main();
