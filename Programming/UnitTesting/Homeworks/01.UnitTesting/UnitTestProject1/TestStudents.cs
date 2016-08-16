namespace StudentSystem.Tests
{
    using Models;
    using Models.Utils;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class TestStudents
    {
        [Test]
        public void CreatingNewStudent_ShouldGenerateIdInAllowedRange()
        {
            var student = new Student("Pesho");

            Assert.GreaterOrEqual(student.Id, Constants.ID_MIN_VALUE);
            Assert.LessOrEqual(student.Id, Constants.ID_MAX_VALUE);
        }

        //[Test]
        //public void CreatingMultipleStudents_ShouldThrowOutOfRangeException()
        //{
        //    for (int i = Constants.ID_MIN_VALUE; i < Constants.ID_MAX_VALUE; i++)
        //    {
        //        var student = new Student(i.ToString());
        //    }

        //    Assert.Throws<ArgumentOutOfRangeException>(()=> new Student("Pesho"));
        //}

        [TestCase(null)]
        [TestCase("       ")]
        public void CreateNewStudent_WithEmptyOrWhiteSpaceUserName_ShouldThrowArgumentException(string name)
        {
            Assert.Throws<ArgumentNullException>(()=> new Student(name));
        }

        [Test]
        public void AddingCourseToStudent_ShouldPass()
        {
            var student = new Student("Pesho");
            var course = new Course("Math");
            course.Subscribe(student);

            Assert.AreEqual(course.Students.Count, 1);
        }

        [Test]
        public void StudentShouldSubscribeToCourseOnlyOnce()
        {
            var student = new Student("Pesho");
            var course = new Course("Math");
            course.Subscribe(student);
            course.Subscribe(student);
            course.Subscribe(student);

            Assert.AreEqual(course.Students.Count, 1);
        }

        [Test]
        public void AddingMultipleStudentsToCourse()
        {
            var course = new Course("Biology");

            for (int i = 0; i < 35; i++)
            {
                var student = new Student(i.ToString());
                course.Subscribe(student);
            }

            Assert.AreEqual(course.Students.Count, Constants.MAX_STUDENTS_IN_COURSE);
        } 

        [TestCase("Pesho")]
        [TestCase("Gosho")]
        public void UnsibscribingStudentFromCourse_ShouldPass(string name)
        {
            var course = new Course("Math");
            var student = new Student(name);
            course.Subscribe(student);
            course.Unsubscribe(student);

            Assert.AreEqual(course.Students.Count, 0);
        }

        [Test]
        public void UnsubscribingNotSubscribedStudent_ShouldDoNothing()
        {
            var course = new Course("Math");
            var student = new Student("Pesho");
            var pesho = new Student("Pesho");
            course.Subscribe(student);
            course.Unsubscribe(pesho);

            Assert.AreEqual(course.Students.Count, 1);
        }
    }
}
