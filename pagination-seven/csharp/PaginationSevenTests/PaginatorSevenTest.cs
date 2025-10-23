using PaginationSeven;

namespace PaginationSevenTests;
public class PaginatorSevenTest
{
    [Test]
    public void DisplayAllPagesWhenThereAreLessPagesThanTheNumberToDisplay()
    {
        Assert.That(new PaginatorSeven().Paginate(totalPages: 5, currentPage: 2), Is.EqualTo("1 (2) 3 4 5"));
    }

    //[Test]
    public void AlwaysDisplayTheFirstAndLastPages()
    {
        Assert.That(new PaginatorSeven().Paginate(totalPages: 100, currentPage: 42), Is.EqualTo("1 … 41 (42) 43 … 100"));
    }

    //[TestCase(1, "(1) 2 3 4 5 … 9")]
    //[TestCase(2, "1 (2) 3 4 5 … 9")]
    //[TestCase(4, "1 2 3 (4) 5 … 9")]
    //[TestCase(6, "1 … 5 (6) 7 8 9")]
    //[TestCase(8, "1 … 5 6 7 (8) 9")]
    //[TestCase(9, "1 … 5 6 7 8 (9)")]
    public void DoNotDisplayGroupedPagesWhenWeAreNearTheFirstOrLast(int currentPage, string expected)
    {
        Assert.That(new PaginatorSeven().Paginate(totalPages: 9, currentPage), Is.EqualTo(expected));
    }
}
