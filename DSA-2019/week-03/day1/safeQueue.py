from queue import Queue


class SafeQueue(Queue):
    def __init__(self):
        Queue.__init__(self)
        self.patients = []

    def set_the_safe_queue(self):
        self.patients = sorted(self.patients, key=lambda x: x.severity, reverse=True)

    def get_the_safe_queue(self):
        self.set_the_safe_queue()
        self.remove_the_healthy_patient()
        if len(self.patients) != 0:
            return self.patients
        else:
            return None

    patients = property(set_the_safe_queue(), get_the_safe_queue())
