<?php

function convertTemperature($celsius)
{
    return [$celsius + 273.15, $celsius * 1.80 + 32];
}
