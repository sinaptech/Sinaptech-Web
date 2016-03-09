app.controller('diseaseController', function ($scope, diseaseService) {
 

    //Function to Reset Scope variables
    function initialize() {
        $scope.NameGen = "";
        $scope.NameSci = "";
        $scope.Desription = "";
    
    }


    //Function to Submit the form
    $scope.submitForm = function () {
        var Disease = {};
        Disease.NameGen = $scope.NameGen;
        Disease.NameSci = $scope.NameSci;
        Disease.Desription = $scope.Desription;
     

        var promisePost = diseaseService.postInfo(Disease);
        promisePost.then(function (d) {
            $scope.DiseaseId = d.data.DiseaseId;
        }, function (err) {
            alert("Some Error Occured ");
        });
    };
    //Function to Cancel Form
    $scope.cancelForm = function () {
       
        initialize();
    };
});