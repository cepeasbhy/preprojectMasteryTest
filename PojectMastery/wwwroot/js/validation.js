function validateProductForm() {
    $("#product-form").validate({
        rules: {
            name: "required",
            category: "required",
            sku: "required",
            color: "required",
            size: {
                required: true,
                number: true
            },
            weight: {
                required: true,
                number: true
            },
            price: {
                required: true,
                number: true
            },
            description: "required",
            productPhoto: {
                required: true,
                accept: "image/jpg, image/jpeg, image/png"
            }
        },
        messages: {
            name: "This field is required",
            category: "This field is required",
            sku: "This field is required",
            color: "This field is required",
            size: {
                required: "This field is required",
                number: "Please enter a valid number"
            },
            weight: {
                required: "This field is required",
                number: "Please enter a valid number"
            },
            weight: {
                required: "This field is required",
                number: "Please enter a valid number"
            },
            description: "Provide a description for your product",
            productPhoto: {
                required: "Upload a photo for your product",
                accept: "Only jpg, jpeg, and png are accepted"
            }
        }
    })
}
