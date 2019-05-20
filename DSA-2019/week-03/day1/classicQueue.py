from queue import Queue


class ClassicQueue(Queue):
    def __init__(self):
        Queue.__init__(self)
        self.patients = []

    def get_the_classic_queue(self):
        self.remove_the_healthy_patient()
        if len(self.patients) > 0:
            return self.patients
        else:
            return None

