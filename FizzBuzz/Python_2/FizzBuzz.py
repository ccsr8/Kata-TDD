class FizzBuzz:
    def Say(self, number):
        result = '{}'.format(number)

        isDivisible3 = number % 3 == 0
        isDivisible5 = number % 5 == 0

        if isDivisible3 and isDivisible5:
            result = 'FizzBuzz'
        elif isDivisible3:
            result = 'Fizz'
        elif isDivisible5:
            result = 'Buzz'

        return result
