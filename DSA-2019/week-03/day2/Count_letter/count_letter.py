class Count_letter:
    def count_letter(self, string):
        letter_count = {}
        if isinstance(string, str):
            for c in string:
                try:
                    letter_count[c] += 1
                except:
                    letter_count[c] = 1

        return letter_count
