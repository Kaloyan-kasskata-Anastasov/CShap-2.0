using NUnit.Framework;
using System;

namespace Database.Tests
{
[TestFixture]
public class DatabaseTests
{
    private Database database;

    [SetUp]
    public void Setup()
    {
        this.database = new Database();
    }

    [Test]
    public void Constructor_WithValidData_ShouldAddElementsAndSetCount()
    {
        this.database = new Database(1, 2, 3, 4, 5);
        Assert.AreEqual(5, this.database.Count);
    }

    [Test]
    public void Constructor_WithMoreThan16Elements_ShouldThrowInvalidOperationException()
    {
        int[] elements = new int[17];
        Assert.Throws<InvalidOperationException>(() => { this.database = new Database(elements); });
    }

    [Test]
    public void Add_WithValidElement_ShouldIncreaseCount()
    {
        this.database.Add(10);
        Assert.AreEqual(1, this.database.Count);
    }

    [Test]
    public void Add_WhenCapacityIsFull_ShouldThrowInvalidOperationException()
    {
        for (int i = 0; i < 16; i++)
        {
            this.database.Add(i);
        }

        Assert.Throws<InvalidOperationException>(() => { this.database.Add(17); });
    }

    [Test]
    public void Remove_WithValidElements_ShouldDecreaseCount()
    {
        this.database.Add(10);
        this.database.Add(20);

        this.database.Remove();

        Assert.AreEqual(1, this.database.Count);
    }

    [Test]
    public void Remove_WhenDatabaseIsEmpty_ShouldThrowInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => { this.database.Remove(); });
    }

    [Test]
    public void Fetch_ShouldReturnCopyOfArrayWithCorrectElements()
    {
        this.database.Add(1);
        this.database.Add(2);
        this.database.Add(3);

        int[] fetchedArray = this.database.Fetch();
        int[] expectedArray = new int[] { 1, 2, 3 };

        CollectionAssert.AreEqual(expectedArray, fetchedArray);
    }
}
}
