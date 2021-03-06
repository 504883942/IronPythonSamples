from System import Random



class Config:
        beginDate="2017/01/01 10:00:00"
        endDate="2017/02/02 15:00:00"


class GameError(Exception):
    pass

class FlippingGame(object):


    def __init__(self, bankroll=500, history=[], seed=None):
        self.beginDate="2017/01/01 10:00:00"
        self.endDate="2017/02/02 15:00:00"
        self.history = history
        self.bankroll = self.initial_bankroll = bankroll
        self.rand = Random(seed) if seed is not None else Random()

    def average(self,data):
        return sum( data)/len( data),100,22,22,55

    def check_wager(self, wager):
        if wager < 1:
            return "You must wager at least one credit."
        
        if wager > self.bankroll:
            return "You cannot wager more than your bankroll."

    def flip(self, guess, wager):
        assert 1 <= wager <= self.bankroll
        assert guess in "TH"

        result = self._do_flip()
        self.history.append((result, guess, wager))
        if result == guess:
            self.bankroll += wager
            return True, result
        else:
            self.bankroll -= wager
            return False, result

    def _do_flip(self):
        return "TH"[self.rand.Next(2)]

    def dosomesth(self):
        return "thx"

