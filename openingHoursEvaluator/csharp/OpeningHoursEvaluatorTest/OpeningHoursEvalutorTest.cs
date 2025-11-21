using System.Diagnostics.CodeAnalysis;

namespace OpeningHoursEvaluatorTest
{
    public class OpeningHoursEvalutorTest
    {
        // 2025-11-17 is a Monday
        [TestCase("2025-11-17T10:00", true, "In the range")]
       // [TestCase("2025-11-17T07:00", false, "Outside of the range")]
       // [TestCase("2025-11-17T08:00", true, "Just at the start of the range, should be considered open")]
       // [TestCase("2025-11-17T17:00", false, "Just at the end of the range, should be considered closed")]
        public void SimpleRange(string now, bool isOpen, string message)
        {
            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo 08:00-17:00");
            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        }

       // [TestCase("2025-11-17T10:00", true, "In the range, on Monday")]
       // [TestCase("2025-11-18T10:00", false, "On a Tuesday, so outside of every range")]
       // [TestCase("2025-11-19T10:00", true, "In the range, on Wednesday")]
        public void SimpleRangeOnSeveralDays(string now, bool isOpen, string message)
        {
            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo,We 08:00-17:00");
            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        }

       // [TestCase("2025-11-17T10:00", true, "In the range, on Monday")]
       // [TestCase("2025-11-18T10:00", true, "In the range, on Tuesday")]
       // [TestCase("2025-11-19T10:00", true, "In the range, on Wednesday")]
       // [TestCase("2025-11-20T10:00", false, "On Thursday so outside of every range")]
        public void SimpleRangeOnARangeOfDays(string now, bool isOpen, string message)
        {
            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-We 08:00-17:00");
            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        }

        //        [TestCase("2025-11-17T10:00", true, "In the first range of hours")]
        //        [TestCase("2025-11-17T18:00", false, "Between both range of hours")]
        //        [TestCase("2025-11-17T20:00", true, "In the 2nd range of hour")]
        //        public void SeveralRangesOfHours(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-We 08:00-16:30,19:00-21:15");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T09:00", false, "On Monday it's the last declaration that works, so at 9:00 we're closed")]
        //        [TestCase("2025-11-17T17:00", true, "On Monday it's the last declaration that works, so at 17:00 we're opened")]
        //        [TestCase("2025-11-18T09:00", true, "For Tuesday there is a single declaration, so at 9:00 we're opened")]
        //        [TestCase("2025-11-18T17:00", false, "For Tuesday there is a single declaration, so at 17:00 we're closed")]
        //        public void TheLastDeclarationOverrideThePreviousOne(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Tu 08:00-16:30;Mo 10:00-18:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T19:00", false, "Before the range")]
        //        [TestCase("2025-11-17T23:00", true, "In the range, before midnight")]
        //        [TestCase("2025-11-18T00:00", true, "In the range, at midnight")]
        //        [TestCase("2025-11-18T01:00", true, "In the range, after midnight")]
        //        [TestCase("2025-11-18T03:00", false, "After the range")]
        //        public void ClosingAfterMidnightWithTheFormat_HigherThan24(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo 20:00-26:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T19:00", false, "Before the range")]
        //        [TestCase("2025-11-17T23:00", true, "In the range, before midnight")]
        //        [TestCase("2025-11-18T00:00", true, "In the range, at midnight")]
        //        [TestCase("2025-11-18T01:00", true, "In the range, after midnight")]
        //        [TestCase("2025-11-18T03:00", false, "After the range")]
        //        public void ClosingAfterMidnightWithTheFormat_TwoRanges(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo 20:00-24:00,Tu 00:00-02:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T13:00", true, "Inside the overriding range for Monday")]
        //        [TestCase("2025-11-17T21:00", false, "The first range for Monday is overriden, so we're closed")]
        //        [TestCase("2025-11-18T01:00", true, "The range for Tuesday is not overriden, so we're open")]
        //        public void TrickyOverrideWithRangeAfterMidnight(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo 20:00-26:00,Mo 12:00-15:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T12:00", false, "November 17th has a particular range, and at 12:00 we're outside")]
        //        public void ParticularDayOfAMonth(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Su 08:00-20:00; Nov 17 09:00-11:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-17T12:00", false, "On November 17th we're closed all day")]
        //        public void OffKeyword(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Su 08:00-20:00; Nov 17 off");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-10T12:00", false, "On the 2nd Monday of the month we're closed")]
        //        [TestCase("2025-11-17T12:00", true, "Nothing particular for the 3rd Monday of the month so we're openat 12:00")]
        //        public void NthOccurenceOfEveryMonth(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Su 08:00-20:00; Mo[2] off");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-11-10T12:00", true, "This is a usual Monday")]
        //        [TestCase("2025-11-17T12:00", false, "2nd Monday before the end of the month, we're closed")]
        //        public void NthLastOccurenceOfEveryMonth(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Su 08:00-20:00; Mo[-2] off");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }
        //
        //        [TestCase("2025-10-06T13:00", true, "A Monday in October is a classical Monday")]
        //        [TestCase("2025-11-17T13:00", false, "A Monday in November has the override")]
        //        [TestCase("2025-12-01T13:00", false, "A Monday in December has the override")]
        //        public void RangeOfMonths(string now, bool isOpen, string message)
        //        {
        //            var sut = new OpeningHoursEvaluator.OpeningHoursEvaluator("Mo-Su 08:00-20:00; Nov-Dec Mo 08:00-12:00");
        //            Assert.That(sut.IsOpenAt(DateTime.Parse(now)), Is.EqualTo(isOpen), message);
        //        }

    }
}
