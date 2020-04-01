using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateEmptyAnimalShelter()
        {
            //Arrange
            //Act
            AnimalShelter testShelter = new AnimalShelter();

            //Assert
            Assert.Null(testShelter.Front);
        }

        [Fact]
        public void TestCanAddDogToAnimalShelter()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();
            Animal testDog = new Animal("Winston", "Dog");

            //Act
            testShelter.Enqueue(testDog);

            //Assert
            Assert.Equal("Winston", testShelter.Rear.Name);
        }

        [Fact]
        public void TestCanAddMultipleAnimalsToAnimalShelter()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();
            Animal winston = new Animal("Winston", "Dog");
            Animal whiskers = new Animal("Whiskers", "Cat");
            Animal murphy = new Animal("Murphy", "Dog");


            //Act
            testShelter.Enqueue(winston);
            testShelter.Enqueue(whiskers);
            testShelter.Enqueue(murphy);

            //Assert
            Assert.Equal("Murphy", testShelter.Front.Next.Next.Name);
        }

        [Fact]
        public void TestCanDequeueDogFromShelterFrontOfLine()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();
            Animal romeo = new Animal("Romeo", "Dog");
            Animal pookie = new Animal("Pookie", "Cat");
            Animal tucker = new Animal("Tucker", "Dog");
            testShelter.Enqueue(romeo);
            testShelter.Enqueue(pookie);
            testShelter.Enqueue(tucker);

            //Act
            testShelter.Dequeue("dog");

            //Assert
            Assert.Equal("Tucker", testShelter.Front.Next.Name);
        }

        [Fact]
        public void TestDequeueCorrectlyThrowsExceptionForEmptyShelter()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();

            //Act
            Exception e = Assert.Throws<Exception>(() => testShelter.Dequeue("cat"));
            string expectedMessage = "Cannot dequeue animal from empty animal shelter.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanDequeueCatFromShelterMiddleOfLine()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();
            Animal romeo = new Animal("Romeo", "Dog");
            Animal pookie = new Animal("Pookie", "Cat");
            Animal tucker = new Animal("Tucker", "Dog");
            testShelter.Enqueue(romeo);
            testShelter.Enqueue(pookie);
            testShelter.Enqueue(tucker);

            //Act
            Animal chosenAnimal = testShelter.Dequeue("cat");

            //Assert
            Assert.Equal("Pookie", chosenAnimal.Name);
        }

        [Fact]
        public void TestDequeueCorrectlyReturnsNullIfShelterDoesNotHavePreferredSpecies()
        {
            //Arrange
            AnimalShelter testShelter = new AnimalShelter();
            Animal romeo = new Animal("Romeo", "Dog");
            Animal barney = new Animal("Barney", "Dog");
            Animal tucker = new Animal("Tucker", "Dog");
            testShelter.Enqueue(romeo);
            testShelter.Enqueue(barney);
            testShelter.Enqueue(tucker);

            //Act
            Animal chosenAnimal = testShelter.Dequeue("cat");

            //Assert
            Assert.Null(chosenAnimal);
        }
    }
}
