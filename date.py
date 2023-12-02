import datetime

class DateTime:
    def get_current_date(self):
        return datetime.date.today()

    def get_current_time(self):
        return datetime.datetime.now().time()
