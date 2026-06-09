using NUnit.Framework;
using System;
using System.Linq;

namespace FightingArena.Tests
{
[TestFixture]
public class ArenaTests
{
    private Arena arena;

    [SetUp]
    public void Setup()
    {
        this.arena = new Arena();
    }

    [Test]
    public void Constructor_ShouldInitializeWarriorsCollection()
    {
        Assert.IsNotNull(this.arena.Warriors);
        Assert.AreEqual(0, this.arena.Count);
    }

    [Test]
    public void Enroll_WithNewWarrior_ShouldAddWarriorToArena()
    {
        Warrior warrior = new Warrior("Pesho", 50, 100);
        this.arena.Enroll(warrior);

        Assert.AreEqual(1, this.arena.Count);
        Assert.IsTrue(this.arena.Warriors.Any(w => w.Name == "Pesho"));
    }

    [Test]
    public void Enroll_WithAlreadyEnrolledWarrior_ShouldThrowInvalidOperationException()
    {
        Warrior warrior = new Warrior("Pesho", 50, 100);
        this.arena.Enroll(warrior);

        Warrior duplicateWarrior = new Warrior("Pesho", 60, 120);

        Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(duplicateWarrior));
    }

    [Test]
    public void Fight_WithMissingAttacker_ShouldThrowInvalidOperationException()
    {
        Warrior defender = new Warrior("Gosho", 50, 100);
        this.arena.Enroll(defender);

        Assert.Throws<InvalidOperationException>(() => this.arena.Fight("Pesho", "Gosho"));
    }

    [Test]
    public void Fight_WithMissingDefender_ShouldThrowInvalidOperationException()
    {
        Warrior attacker = new Warrior("Pesho", 50, 100);
        this.arena.Enroll(attacker);

        Assert.Throws<InvalidOperationException>(() => this.arena.Fight("Pesho", "Gosho"));
    }

    [Test]
    public void Fight_WithValidWarriors_ShouldExecuteAttackLogic()
    {
        Warrior attacker = new Warrior("Pesho", 50, 100);
        Warrior defender = new Warrior("Gosho", 40, 100);

        this.arena.Enroll(attacker);
        this.arena.Enroll(defender);

        this.arena.Fight("Pesho", "Gosho");

        Assert.AreEqual(60, attacker.HP);
        Assert.AreEqual(50, defender.HP);
    }
}
}
