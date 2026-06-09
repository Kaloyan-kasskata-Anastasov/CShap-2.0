using NUnit.Framework;
using System;

namespace ExtendedDatabase.Tests
{
[TestFixture]
public class ExtendedDatabaseTests
{
    private Database database;

    [SetUp]
    public void Setup()
    {
        // Инициализираме празна база преди всеки тест
        this.database = new Database();
    }

    [Test]
    public void Constructor_WithValidData_ShouldAddPersonsAndSetCount()
    {
        Person p1 = new Person(1, "Ivan");
        Person p2 = new Person(2, "Gosho");

        this.database = new Database(p1, p2);

        Assert.AreEqual(2, this.database.Count);
    }

    [Test]
    public void Constructor_WithMoreThan16Persons_ShouldThrowArgumentException()
    {
        Person[] persons = new Person[17];
        for (int i = 0; i < 17; i++)
        {
            persons[i] = new Person(i, $"User{i}");
        }

        // В твоя код AddRange хвърля ArgumentException, ако са над 16
        Assert.Throws<ArgumentException>(() => { this.database = new Database(persons); });
    }

    [Test]
    public void Add_ValidPerson_ShouldIncreaseCount()
    {
        Person p1 = new Person(1, "Ivan");
        this.database.Add(p1);

        Assert.AreEqual(1, this.database.Count);
    }

    [Test]
    public void Add_WhenCapacityIsFull_ShouldThrowInvalidOperationException()
    {
        for (int i = 0; i < 16; i++)
        {
            this.database.Add(new Person(i, $"User{i}"));
        }

        Assert.Throws<InvalidOperationException>(() => { this.database.Add(new Person(16, "ExtraUser")); });
    }

    [Test]
    public void Add_DuplicateUsername_ShouldThrowInvalidOperationException()
    {
        Person p1 = new Person(1, "Ivan");
        Person p2 = new Person(2, "Ivan"); // Дублирано име [cite: 599]

        this.database.Add(p1);

        Assert.Throws<InvalidOperationException>(() => { this.database.Add(p2); });
    }

    [Test]
    public void Add_DuplicateId_ShouldThrowInvalidOperationException()
    {
        Person p1 = new Person(1, "Ivan");
        Person p2 = new Person(1, "Gosho"); // Дублирано ID [cite: 600]

        this.database.Add(p1);

        Assert.Throws<InvalidOperationException>(() => { this.database.Add(p2); });
    }

    [Test]
    public void Remove_WithValidElements_ShouldDecreaseCount()
    {
        Person p1 = new Person(1, "Ivan");
        this.database.Add(p1);

        this.database.Remove();

        Assert.AreEqual(0, this.database.Count);
    }

    [Test]
    public void Remove_FromEmptyDatabase_ShouldThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => { this.database.Remove(); });
    }

    [TestCase(null)]
    [TestCase("")]
    public void FindByUsername_NullOrEmptyUsername_ShouldThrowArgumentNullException(string invalidUsername)
    {
        Assert.Throws<ArgumentNullException>(() => { this.database.FindByUsername(invalidUsername); });
    }

    [Test]
    public void FindByUsername_NonExistentUsername_ShouldThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => { this.database.FindByUsername("NonExistent"); });
    }

    [Test]
    public void FindByUsername_ValidUsername_ShouldReturnCorrectPerson()
    {
        Person expectedPerson = new Person(1, "Ivan");
        this.database.Add(expectedPerson);

        Person actualPerson = this.database.FindByUsername("Ivan");

        Assert.AreEqual(expectedPerson, actualPerson);
    }

    [Test]
    public void FindByUsername_ShouldBeCaseSensitive()
    {
        Person person = new Person(1, "Ivan");
        this.database.Add(person);

        Assert.Throws<InvalidOperationException>(() => { this.database.FindByUsername("ivan"); });
    }

    [Test]
    public void FindById_NegativeId_ShouldThrowArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => { this.database.FindById(-1); });
    }

    [Test]
    public void FindById_NonExistentId_ShouldThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => { this.database.FindById(999); });
    }

    [Test]
    public void FindById_ValidId_ShouldReturnCorrectPerson()
    {
        Person expectedPerson = new Person(1, "Ivan");
        this.database.Add(expectedPerson);

        Person actualPerson = this.database.FindById(1);

        Assert.AreEqual(expectedPerson, actualPerson);
    }
}
}
