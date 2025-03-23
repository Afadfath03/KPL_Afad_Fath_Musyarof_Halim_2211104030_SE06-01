from enum import Enum
import time

class TrafficLightState(Enum):
    MERAH = "Merah"
    HIJAU = "Hijau"
    KUNING = "Kuning"

state_transitions = {
    TrafficLightState.MERAH: TrafficLightState.HIJAU,
    TrafficLightState.HIJAU: TrafficLightState.KUNING,
    TrafficLightState.KUNING: TrafficLightState.MERAH
}

state_duration = {
    TrafficLightState.MERAH: 5,
    TrafficLightState.HIJAU: 10,
    TrafficLightState.KUNING: 2
}

current_state = TrafficLightState.MERAH
# next_state = state_transitions(current_state)
# print(f"Next state: {next_state}")

while True:
    print(f"Lampu: {current_state.value} ({state_duration(current_state)}) detik")
    time.sleep(state_duration(current_state))
    current_state = state_transitions(current_state)
    print(f"Next state: {current_state.value}")
    print("")