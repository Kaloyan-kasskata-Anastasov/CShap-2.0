using NUnit.Framework;
using System;

namespace FightingArena.Tests
{
[TestFixture]
public class WarriorTests
{
    [Test]
    public void Constructor_WithValidParameters_ShouldSetPropertiesCorrectly()
    {
        Warrior warrior = new Warrior("Pesho", 50, 100);

        Assert.AreEqual("Pesho", warrior.Name);
        Assert.AreEqual(50, warrior.Damage);
        Assert.AreEqual(100, warrior.HP);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void Constructor_WithNullEmptyOrWhitespaceName_ShouldThrowArgumentException(string invalidName)
    {
        Assert.Throws<ArgumentException>(() => new Warrior(invalidName, 50, 100));
    }

    [TestCase(0)]
    [TestCase(-10)]
    public void Constructor_WithZeroOrNegativeDamage_ShouldThrowArgumentException(int invalidDamage)
    {
        Assert.Throws<ArgumentException>(() => new Warrior("Pesho", invalidDamage, 100));
    }

    [Test]
    public void Constructor_WithNegativeHP_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 50, -10));
    }

    [TestCase(30)]
    [TestCase(20)]
    public void Attack_WhenAttackerHPIs30OrBelow_ShouldThrowInvalidOperationException(int attackerHp)
    {
        Warrior attacker = new Warrior("Pesho", 50, attackerHp);
        Warrior defender = new Warrior("Gosho", 40, 100);

        Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
    }

    [TestCase(30)]
    [TestCase(20)]
    public void Attack_WhenDefenderHPIs30OrBelow_ShouldThrowInvalidOperationException(int defenderHp)
    {
        Warrior attacker = new Warrior("Pesho", 50, 100);
        Warrior defender = new Warrior("Gosho", 40, defenderHp);

        Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
    }

    [Test]
    public void Attack_WhenAttackerHPIsLessThanDefenderDamage_ShouldThrowInvalidOperationException()
    {
        Warrior attacker = new Warrior("Pesho", 50, 40);
        Warrior defender = new Warrior("Gosho", 50, 100); // Gosho's damage is 50, Pesho's HP is 40

        Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
    }

    [Test]
    public void Attack_WithValidWarriors_ShouldDecreaseAttackerHPByDefenderDamage()
    {
        Warrior attacker = new Warrior("Pesho", 50, 100);
        Warrior defender = new Warrior("Gosho", 40, 100);

        attacker.Attack(defender);

        int expectedAttackerHp = 100 - 40; // 60
        Assert.AreEqual(expectedAttackerHp, attacker.HP);
    }

    [Test]
    public void Attack_WhenAttackerDamageIsLessThanDefenderHP_ShouldDecreaseDefenderHP()
    {
        Warrior attacker = new Warrior("Pesho", 50, 100);
        Warrior defender = new Warrior("Gosho", 40, 100);

        attacker.Attack(defender);

        int expectedDefenderHp = 100 - 50; // 50
        Assert.AreEqual(expectedDefenderHp, defender.HP);
    }

    [Test]
    public void Attack_WhenAttackerDamageIsGreaterThanDefenderHP_ShouldSetDefenderHPToZero()
    {
        Warrior attacker = new Warrior("Pesho", 150, 100);
        Warrior defender = new Warrior("Gosho", 40, 100);

        attacker.Attack(defender);

        Assert.AreEqual(0, defender.HP);
    }
}
}
