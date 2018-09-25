class FizzBuzz:
    def Say(self, number):
        result = '{}'.format(number)

        isCanDivied3 = number % 3 == 0
        isCanDivied5 = number % 5 == 0

        if isCanDivied3 & isCanDivied5:
            result = 'FizzBuzz'
        elif isCanDivied3:
            result = 'Fizz'
        elif isCanDivied5:
            result = 'Buzz'

        return result
