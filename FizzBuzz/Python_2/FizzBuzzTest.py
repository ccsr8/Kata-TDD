import unittest
import FizzBuzz


class FizzBuzzTest(unittest.TestCase):
    def setUp(self):
        self.sut = FizzBuzz.FizzBuzz()

    def test_Say_NumberNotDivisible3Or5_ReturnNumber(self):
        # arrange
        expected = '1'

        # act
        result = self.sut.Say(1)

        # assert
        self.assertEqual(expected, result)

    def test_Say_NumberIsDivisible3_ReturnFizz(self):
        # arrange
        expected = 'Fizz'

        # act
        result = self.sut.Say(3)

        # assert
        self.assertEqual(expected, result)

    def test_Say_NumberIsDivisible5_ReturnBuzz(self):
        # arrange
        expected = 'Buzz'

        # act
        result = self.sut.Say(5)

        # assert
        self.assertEqual(expected, result)

    def test_Say_NumberIsDivisible3And5_ReturnFizzBuzz(self):
        # arrange
        expected = 'FizzBuzz'

        # act
        result = self.sut.Say(15)

        # assert
        self.assertEqual(expected, result)


if __name__ == '__main__':
    unittest.main
