namespace TestProject2
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var numbers = new int[] { 1, 2 };
			Assert.Equal([1, 2], numbers);
		}
	}
}