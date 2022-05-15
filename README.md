# taps_simu_visualization


## Documents related to the case study are in folder "case", including:
1. File, "behavior_models_with_system_device_models_and_service_context_models.xml", gives the system device models and the service context models mentioned in case study. 
2. Folder, "Assets", gives the animation assets.
3. File, "case-study-taps.txt", gives the 30 TAPs providered by the end user in case study.
4. File, "instancesInformation.properties", gives the spacial location of human and the device instances in case study.
5. File, "synthesized_system_behavior_model.xml", is the synthesized system behavior model generated in step 1 "synthesize the system behavior model" in case study.
6. Files, "service_scenario1_with_rain_behavior_1.xml", "service_scenario2_with_rain_behavior_2.xml", and "service_scenario3_with_rain_behavior_3.xml", are generated service scenarios in case study.
7. File, "simulation_traces_of_service_scenario_with_rain_behavior_2.txt", gives the simulation traces generated after simulation of service scenario 2 "service_scenario2_with_rain_behavior_2.xml" in case study.
8. File, "animation_specification_of_service_scenario2.json", is the corresponding animation specification consisting of a several frames under the service scenario 2 in case study.
9. File, "animation_video.mp4", is the generated animation corresponding to animation specification of ""animation_specification_of_service_scenario2.json"" in case study.

## The relation codes are in folder "codes", including:
1. **synthesis_simulation-code**: Including the code of the synthesis of the system behavior model, the generation of the service scenarios, and the simulation of the service scenarios. It takes the system device models, the TAPs,  the service context models, the TAPs, and the instance information as the inputs, and outputs the synthesized system behavior model, the service scenarios, and finally the simulation traces of each scenario. <br>
		* Before running, we should reset the address information in java code: synthesis_simulation-code\simulation-visualization\src\main\java\com\example\demo\serviceAddressService.java. <br>
			>> 1) The "MODEL_FILE_PATH" is the path of the behavior model, e.g. "behavior_models_with_system_device_models_and_service_context_models.xml".<br>
			>> 2) The "UPPAAL_PATH" is the path of the executable file "uppaal.exe" in platform UPPAAL-SMC. Tool UPPAAL-SMC should be downloaded first.<br>
					>>>> Simulation is procceed under [uppaal-4.1.24](https://uppaal.org/downloads/).<br>
			>> 3) The "ONTOLOGY_FILE_NAME" should be the file name of the behavior model, e.g. "behavior_models_with_system_device_models_and_service_context_models.xml".<br>
			>> 4) The "DEVICE_POSITION_INFORMATION_FILE_NAME"  is the file name of instance information, e.g. "instancesInformation.properties".<br>
2. **animation-code**: The code of the generation of the animation specification. Taking the simulation traces and the animation asset as the inputs, and outputs the animation specification, and finally the animation.<br>
		>> 2.1 smarthome-master: The code of generating the animation specification.<br>
		>> 2.2 smartunity-master: The unity related code to obtain the visualization animation for the animation specification.<br>
3. **frontend-code**: The front-end code of the tool TAP Animator.<br>
		* Running under Angular CLI: 11.0.7<br>
		* After running, <br>
			>> 1) Add the TAPs. <br>
			>> 2) Click the simulation button, which will generate the system behavior model, then the service scenario, and simulate the service scenario to generate the simulation trace.<br>
			>> 3) Click the visualization, which will generate the animation specification, and finally the animation.<br>


## The running environment:  
A machine that is configured with CPU Inter (R) Core (TM) i74790 @ 3.60GHz, 12.0 G RAM, and Windows 10 (64bit).