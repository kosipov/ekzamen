class Text:
    def reverse(self, s=''):
        return s[::-1]

    def count_words(self, s=''):
        return len(s.split())

    def is_palindrome(self, s=''):
        s = s.lower()
        s = ''.join([c for c in s if c.isalpha()])
        return s == s[::-1]