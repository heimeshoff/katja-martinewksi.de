module Katjanewski.Views.Coaching

open Fable.React
open Fable.React.Props


let coaching model dispatch =
  div [ Class "w-full md:w-2/3 lg:w-1/2" ; Id "coaching & training"]
    [ div [ Class "flex flex-col md:flex-row items-center justify-center space-x-4 space-y-4 "]
        [
          img [ Class "w-1/2 object-contain"
                Src "/img/coaching.png" ]
          div [ Class "md:w-1/2" ]
            [ div [ Class "font-bold text-gray-700 text-3xl" ]
                [ str "Coaching & Training"]
              p [ Class "pr-4 text-justify" ]
                [ str "Falls Du ein Ziel verfolgst und effektiver im Arbeitsleben sein möchtest, aber nicht weißt, wie du es erreichen sollst, kann ich dir durch meine auf dem Prinzip des Solution focused Ansatz basierenden Coaching Methode helfen dieses Ziel zu erreichen." ] 
              p [ Class "pr-4 text-justify" ]
                [ str "Dich erwarten in Trainings mit mir ein hoher Grad an Interaktion, damit aus Theorie auch Praxis wird." ] ] 
        ]
    ]