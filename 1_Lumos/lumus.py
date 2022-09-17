import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(18, GPIO.OUT)
GPIO.setup(23, GPIO.OUT)

GPIO.output(18, GPIO.HIGH)
GPIO.output(23, GPIO.HIGH)
time.sleep(15)
GPIO.output(18, GPIO.LOW)
GPIO.output(23, GPIO.LOW)

# -> znak komenatrza
# time.sleep(10) -> poczekaj 10 sekund
# GPIO.output(1, GPIO.LOW) -> niski sygnał na pin 1
# GPIO.output(1, GPIO.HIGH) -> wysoki sygnał na pin 1 

# while True:
    # -> pętla nieskończona  



    