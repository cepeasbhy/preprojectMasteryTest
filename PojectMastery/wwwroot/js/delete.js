function handleDelete(Id) {
    Swal.fire({
        title: "Proceed?",
        text: "This action cannot be undone",
        icon: "warning",
        showCancelButton: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Product/DeleteProduct/" + Id,
                processData: false,
                dataType: false,
                contentType: false,
                success: () => {
                    Swal.fire({
                        title: "Success",
                        text: "Item has been deleted",
                        icon: "success",
                        showCancelButton: false,
                        allowOutsideClick: false
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.reload();
                        }
                    })
                },
                error: () => {
                    Swal.fire({
                        title: "Failed",
                        text: "Something went wrong",
                        icon: "failed",
                        showCancelButton: false,
                        allowOutsideClick: false
                    });
                }
            });
        }
    })
}