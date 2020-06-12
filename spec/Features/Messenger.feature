
Feature: ObtenerSaludo

    @mytag
    Scenario: Acceder colocar mi nombre y recibir un saludo
        Given i go to app
        When i enter my name 'Luis'
        When i click the button
        Then should see 'Mensaje: hola Luis'
