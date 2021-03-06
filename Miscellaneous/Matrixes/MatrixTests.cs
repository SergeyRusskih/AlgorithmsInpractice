﻿using Xunit;

namespace Miscellaneous.Matrixes
{
    public class MatrixTests
    {
        private readonly BruteForce _bruteForce;

        public MatrixTests()
        {
            _bruteForce = new BruteForce();
        }

        [Fact]
        public void SimpleInput_Returns_MultiplyedMatrix()
        {
            var first = new[]
            {
                new[] { 1, 4 },
                new[] { 6, 2 },
                new[] { 1, 6 },
            };

            var second = new[]
            {
                new[] { 5, 4, 9 },
                new[] { 6, 6, 2 },
            };

            var expected = new[]
            {
                new[] { 29, 28, 17 },
                new[] { 42, 36, 58 },
                new[] { 41, 40, 21 },
            };

            var result = _bruteForce.Run(first, second);

            Assert.Equal(expected, result);
        }
    }
}
