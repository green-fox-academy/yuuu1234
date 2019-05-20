from patient import Patient
from queue import Queue


class Hospital:
    def __init__(self, queue):
        if isinstance(queue, Queue):
            self.queue = queue

    def add_patient_to_queue(self, patient):
        if isinstance(patient, Patient):
            self.queue.append(patient)
        else:
            print("not a valid patient")

    def treat_the_next_patient(self):
        self.queue.get_next_patient().treat_illness()
