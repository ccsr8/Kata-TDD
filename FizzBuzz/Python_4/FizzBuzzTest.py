import unittest
import FizzBuzz


class FizzBuzzTest(unittest.TestCase):
    def setUp(self):
        self.sut = FizzBuzz.FizzBuzz()

    def test_Say_NumberNotDivisible3Or5_ReturnNumber(self):
        # arrange
        expected = '1'

        # act
        actual = self.sut.Say(1)

        # assert
        self.assertEqual(expected, actual)

    def test_Say_NumberDivisible3_ReturnFizz(self):
        # arrange
        expected = 'Fizz'

        # act
        actual = self.sut.Say(3)

        # assert
        self.assertEqual(expected, actual)
        
    def test_Say_NumberDisivible5_ReturnBuzz(self):
        # arrange
        expected = 'Buzz'

        # act
        actual = self.sut.Say(5)

        # assert
        self.assertEqual(expected, actual)

    def test_Say_NumberDisivibl3Ande5_ReturnFizzBuzz(self):
        # arrange
        expected = 'FizzBuzz'

        # act
        actual = self.sut.Say(15)

        # assert
        self.assertEqual(expected, actual)


if __name__ == '__main__':
    unittest.main
