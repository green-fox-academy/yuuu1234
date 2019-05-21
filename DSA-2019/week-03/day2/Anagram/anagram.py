class Anagram:
    def is_anagram(self, word1, word2):
        dic1 = {}
        dic2 = {}
        for c1, c2 in zip(word1, word2):
            try:
                dic1[c1] += 1
                dic2[c2] += 1
            except:
                dic1[c1] = 1
                dic2[c2] = 1
        for k, v in dic1.items():
            pass
            if dic2[k] == v:
                pass
            else:
                return False
        if len(dic1) == len(dic2):
            return True
        else:
            return False

