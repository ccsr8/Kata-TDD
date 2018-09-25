import unittest
import FizzBuzz

class FizzBuzzTest(unittest.TestCase):
    def setUp(self):
        self.sut = FizzBuzz.FizzBuzz()

    def test_Say_NumberNotDivisible3Or5_ReturnNumber(self):
        # arrange        
        expect = '1'

        # act
        actual = self.sut.Say(1)

        # assert
        self.assertEqual(expect, actual)

    def test_Say_NumberDivisible3_ReturnFizz(self):
        # arrange
        expect = 'Fizz'

        # act
        actual = self.sut.Say(3)

        # assert
        self.assertEqual(expect, actual)

    def test_Say_NumberDivisible5_ReturnBuzz(self):
        # arrange
        expect = 'Buzz'

        # act
        actual = self.sut.Say(5)

        # assert
        self.assertEqual(expect, actual)

    def test_Say_NumberDivisible3And5_ReturnFizzBuzz(self):
        # arrange
        expect = 'FizzBuzz'

        # act
        actual = self.sut.Say(15)

        # assert
        self.assertEqual(expect, actual)

if __name__ == '__main__':
    unittest.main()