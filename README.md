# taps_simu_visualization
Documents about case study are in folder "case", including:

1. File, "behavior_models_with_system_device_models_and_service_context_models.xml", gives the system device models and the service context models mentioned in case study. 

2. 

3. File, "case-study-taps.txt", gives the 30 TAPs providered by the end user in case study.

4. File, "instancesInformation.properties", gives the spacial location of human and the device instances in case study.

5. File, "synthesized_system_behavior_model.xml", is the synthesized system behavior model generated in step 1 "synthesize the system behavior model" in case study.

6. Files, "service_scenario1_with_rain_behavior_1.xml", "service_scenario2_with_rain_behavior_2.xml", and "service_scenario3_with_rain_behavior_3.xml", are generated service scenarios in case study.

7. File, "simulation_traces_of_service_scenario_with_rain_behavior_2.txt", gives the simulation traces generated after simulation of service scenario 2 "service_scenario2_with_rain_behavior_2.xml" in case study.

8. File, "animation_specification_of_service_scenario2.json", is the corresponding animation specification consisting of a several frames under the service scenario 2 in case study.

9. File, "animation_video.mp4", is the generated animation corresponding to animation specification of ""animation_specification_of_service_scenario2.json"" in case study.

The relation codes are in folder "codes", including:

1. synthesis_simulation-code: Including the code of the synthesis of the system behavior model, the generation of the service scenarios, and the simulation of the service scenarios. It takes the system device models, the TAPs,  the service context models, the TAPs, and the instance information as the inputs, and outputs the synthesized system behavior model, the service scenarios, and finally the simulation traces of each scenario.

2. animation-code: The code of the generation of the animation specification. Taking the simulation traces and the animation asset as the inputs, and outputs the animation specification, and finally the animation.