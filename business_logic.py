class BusinessLogic:
    def calculate_price(self, price, discount):
        if discount < 0 or discount > 100:
            raise ValueError('Discount must be between 0 and 100!')
        return price * (1 - discount / 100)

    def validate_email(self, email):
        if '@' not in email or '.' not in email:
            return False
        return True
